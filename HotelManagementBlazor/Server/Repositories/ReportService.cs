using HotelManagement.Server.Data;
using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public class ReportService
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<ReportService> _logger;

        public ReportService(AppDbContext dbContext, ILogger<ReportService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<byte[]> GenerateGuestReportAsync()
        {
            try
            {
                List<Guest> items = await _dbContext.Guest.ToListAsync();

                // Generate the report using the items data
                StringBuilder reportBuilder = new StringBuilder();
                reportBuilder.AppendLine("FirstName, LastName, Address, BirthDate, MobileNo");

                foreach (Guest item in items)
                {
                    reportBuilder.AppendLine($"{item.FirstName}, {item.LastName}, {item.Address}, {item.BirthDate}, {item.Mobile}");
                }
                _logger.LogInformation("Guest report generated successfully");
                // Convert the report to a byte array
                byte[] reportBytes = Encoding.UTF8.GetBytes(reportBuilder.ToString());

                return reportBytes;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the report generation
                _logger.LogError(ex, "Error while generating guest report");
                throw;
            }
        }

        public async Task<bool> DownloadGuestReportAsync(string filePath)
        {
            try
            {
                byte[] reportBytes = await GenerateGuestReportAsync();

                if (reportBytes == null)
                    return false;

                // Save the report to the specified file path
                await File.WriteAllBytesAsync(filePath, reportBytes);

                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the download process
                Console.WriteLine($"Error downloading guest report: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DownloadMultipleGuestReportsAsync(string directoryPath, int count)
        {
            try
            {
                if (count <= 0)
                    return false;
                for (int i = 1; i <= count; i++)
                {
                    string fileName = $"GuestReport{i}.csv";
                    string filePath = Path.Combine(directoryPath, fileName);

                    bool result = await DownloadGuestReportAsync(filePath);

                    if (!result)
                    {
                        Console.WriteLine($"Error downloading guest report {i}");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the download process
                Console.WriteLine($"Error downloading multiple inward reports: {ex.Message}");
                return false;
            }
        }
    }
}
