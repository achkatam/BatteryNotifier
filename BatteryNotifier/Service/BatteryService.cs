namespace BatteryNotifier.Service;

using System.Windows.Forms;

public static class BatteryService
{
    private static readonly PowerStatus _powerStatus;

    static BatteryService()
    {
        _powerStatus = SystemInformation.PowerStatus;
    }

    public static int GetPercentage()
    {
        var batteryLevel = _powerStatus.BatteryLifePercent;

        // battery level is between 0.00 and 1.00, so we need to multiply it
        return (int)(batteryLevel * 100);
    }

    public static bool IsCharging()
        => _powerStatus.PowerLineStatus == PowerLineStatus.Online;
}