package com.automationtesting;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;

public class StudentRegistrationPage {
	
	@SuppressWarnings("deprecation")
	public static void main(String[] args) throws InterruptedException{
		
		WebDriver driver1 = new EdgeDriver();
		driver1.get("http://quiz-fe-test.hematitecorp.com/");
		driver1.manage().window().maximize();
		Thread.sleep(2000);
		
		driver1.findElement(By.id("basic-menu")).click();
		Thread.sleep(1000);
		
		driver1.findElement(By.xpath("//*[@id=\"basic-menu\"]/div[3]/ul/li[1]")).click();
		Thread.sleep(1000);
		
		driver1.findElement(By.id(":r2:")).sendKeys("Bejesh");
		Thread.sleep(1000);
		driver1.findElement(By.id(":r3:")).sendKeys("Sriram");
		Thread.sleep(1000);		
		driver1.findElement(By.id(":r4:")).sendKeys("bejeshsriram2808@gmail.com");
		Thread.sleep(1000);
		driver1.findElement(By.id(":r5:")).sendKeys("8608925121");
		Thread.sleep(1000);
		driver1.findElement(By.id(":r6:")).sendKeys("Bejesh@2808");
		Thread.sleep(1000);
		driver1.findElement(By.id(":r7:")).sendKeys("Bejesh@2808");
		Thread.sleep(1000);
		driver1.findElement(By.xpath("//div[@aria-haspopup=\"listbox\"]")).click();
		Thread.sleep(1000);
		driver1.findElement(By.xpath("//li[@data-value=\"student\"]")).click();
		Thread.sleep(1000);
		driver1.findElement(By.xpath("//input[@value=\"otherbranch\"]")).click();
		Thread.sleep(1000);
		driver1.findElement(By.id("otherbranch")).sendKeys("Changepond");
		Thread.sleep(1000);
		driver1.findElement(By.xpath("//input[@value=\"male\"]")).click();
		Thread.sleep(1000);		
		driver1.findElement(By.xpath("//button[@type=\"submit\"]")).click();
		Thread.sleep(5000);
		
		driver1.quit();
		
		
		
		
	}
	
}
