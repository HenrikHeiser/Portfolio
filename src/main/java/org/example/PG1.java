package org.example;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.*;
import org.openqa.selenium.chrome.ChromeOptions;

public class PG1 {


    public static void main(String[] args) {

        // declaration and instantiation of objects/variables
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.addArguments("--remote-allow-origins=*");
        System.setProperty("webdriver.chrome.driver","src/main/ChromeDriverExe/chromedriver.exe");
        WebDriver driver = new ChromeDriver(chromeOptions);

        String baseUrl = "http://demo.guru99.com/test/newtours/";
        String expectedTitle = "Henrik";
        String actualTitle = "";

        // launch Chrome and direct it to the Base URL
        driver.get(baseUrl);
        driver.findElement(By.id("userName")).sendKeys("value", "new value");
        // get the actual value of the title
        actualTitle = driver.getTitle();

        /*
         * compare the actual title of the page with the expected one and print
         * the result as "Passed" or "Failed"
         */
        if (actualTitle.contentEquals(expectedTitle)){
            System.out.println("Test Passed!");
        } else {
            System.out.println("Test Failed");
        }

        //close Fire fox
        //driver.close();
    }

}