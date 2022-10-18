Feature: login
 In order to access my account
    As a user of the website
   I want to log into the website
@mytag
Scenario Outline: Successful Login with Valid Credentials
    Given User gives userid and password
       When UserClicksLogin
    Then SuccessfulLogIN message should display

    Scenario: Successful LogOut
    When User LogOut from the Application
    Then Successful LogOut message should display