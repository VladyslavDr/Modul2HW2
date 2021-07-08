using System;
public class Notification
{
    public static void SmsToPhoneNumber(User user)
    {
        Console.WriteLine($"Sms written to {user.PhoneNumber}");
    }

    public static void SmsToMail(User user)
    {
        Console.WriteLine($"Sms written to {user.Mail}");
    }
}