using FastReport;
using System.IO;

namespace OpenReport_Blazor.Services;

public static class ReportTemplateGenerator
{
    public static void CreateSampleInvoiceReport(string wwwrootPath)
    {
        var frxPath = Path.Combine(wwwrootPath, "sample-invoice.frx");
        
        // Only create if it doesn't exist
        if (File.Exists(frxPath))
            return;

        try
        {
            // Create a minimal report using FastReport
            // This creates a basic empty report that can be loaded
            using var report = new Report();
            
            // FastReport creates a default page automatically
            // Just save the empty report - it will be a valid .frx file
            // Users can then load it and design the report, or we can enhance it programmatically later
            report.Save(frxPath);
        }
        catch (Exception ex)
        {
            // Log error but don't crash the app
            Console.WriteLine($"Error creating sample report template: {ex.Message}");
            Console.WriteLine($"Note: You can create .frx files manually using FastReport Designer");
        }
    }
}

