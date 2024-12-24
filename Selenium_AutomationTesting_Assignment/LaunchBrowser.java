package com.automationtesting;


import java.util.concurrent.TimeUnit;

import org.openqa.selenium.Dimension;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class LaunchBrowser {

	@SuppressWarnings("deprecation")
	public static void main(String[] args) throws InterruptedException{
		// TODO Auto-generated method stub
		
		WebDriver driver1 = new ChromeDriver();
			driver1.get("http://quiz-fe-test.hematitecorp.com/");
			System.out.println(driver1.getTitle());
			System.out.println(driver1.getCurrentUrl());
//			System.out.println(driver1.getPageSource());
			Thread.sleep(2000);
			driver1.close();
			
		WebDriver driver2 = new EdgeDriver();
			driver2.get("http://quiz-fe-test.hematitecorp.com/");
			System.out.println(driver2.getTitle());
			System.out.println(driver2.getCurrentUrl());
//			System.out.println(driver2.getPageSource());
			driver2.navigate().to("http://hematiteweb.hematitecorp.com/");
			Thread.sleep(2000);
			driver2.navigate().back();
			Thread.sleep(2000);
			driver2.navigate().forward();
			Thread.sleep(2000);			
			driver2.navigate().refresh();
			Thread.sleep(2000);			
			driver2.manage().window().maximize();
			Thread.sleep(2000);			
			driver2.manage().window().minimize();
			Thread.sleep(2000);			
			driver2.manage().window().setSize(new Dimension(1024,768)); //import from selenium			
//			driver2.switchTo().alert();
			System.out.println(driver2.manage().getCookies());
			Thread.sleep(2000);
			driver2.close();
			
			
			WebDriver driver3 = new FirefoxDriver();
			driver3.get("http://quiz-fe-test.hematitecorp.com/");
				System.out.println(driver3.getTitle());
				System.out.println(driver3.getCurrentUrl());
	//			System.out.println(driver3.getPageSource());
				driver3.navigate().to("http://hematiteweb.hematitecorp.com/");
				Thread.sleep(2000);
				driver3.navigate().back();
				Thread.sleep(2000);
				driver3.navigate().forward();
				Thread.sleep(2000);			
				driver3.navigate().refresh();
				Thread.sleep(2000);			
				driver3.manage().window().maximize();
				Thread.sleep(2000);			
				driver3.manage().window().minimize();
				Thread.sleep(2000);			
				driver3.manage().window().setSize(new Dimension(1024,768)); //import from selenium			
	//			driver2.switchTo().alert();
				System.out.println(driver3.manage().getCookies());
				Thread.sleep(2000);
				driver3.close();
			
			
		
	}

}
