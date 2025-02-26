using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

// Example of how to use the loading animation
public static class Load {
    // Example 2: Use with static helper method (simplest)
    public static async Task Example2(Form parentForm)
    {
        // Show loading with one line
        CustomLoadingAnimation loader = CustomLoadingAnimation.ShowLoading(parentForm, "Processing data...");

        // Simulate async work
        await Task.Delay(3000);

        // Stop when done
        loader.StopAnimation();
        parentForm.Controls.Remove(loader);
        loader.Dispose();
    }

}