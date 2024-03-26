package Bai1.version3;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class Logger
{
    private Logger() { }

    private volatile static Logger uniqueInstance;

    public static Logger getInstance()
    {
        if (uniqueInstance == null) {
            synchronized(Logger.class) {
                if (uniqueInstance == null)
                    System.out.println("is null");
                    uniqueInstance = new Logger();
            }
        }
        return uniqueInstance;
    }

    public void LogMessage(String msg){
        String fileName = "log_v3.txt";
        try {
            FileWriter fileWriter = new FileWriter(fileName, true);

            PrintWriter printWriter = new PrintWriter(fileWriter);
            printWriter.println(msg);

            printWriter.close();

            System.out.println("Message logged v3 successfully.");
        } catch (IOException e) {
            System.out.println("Error while logging message: " + e.getMessage());
            e.printStackTrace();
        }
    }
}