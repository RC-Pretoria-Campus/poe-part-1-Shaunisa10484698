using Microsoft.VisualBasic;
using System;
using System.Security.Principal;
using System.Speech;
using System.Speech.Synthesis;

public class Program
{

    public static void Main()
    {
        String userInput;
        SpeechSynthesizer speech = new SpeechSynthesizer();

        // logo (you must have this method defined somewhere)
        logo();

        // voice greeting
        speech.Speak("Hello, welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.");

        // ask for username
        Console.WriteLine("Bot: Can I get your name please?");
        String userName = Console.ReadLine();

        Console.WriteLine("Bot: " + userName + ", how can I help you?");

        while (true)
        {
            // take input from user
            Console.Write(userName + ": ");
            userInput = Console.ReadLine().ToLower().Trim();

            // phishing / scams
            if (userInput.Contains("phishing") || userInput.Contains("vhishing") || userInput.Contains("scam"))
            {
                Console.WriteLine("Bot: Phishing is a form of social engineering where attackers trick you into giving sensitive information.");
                Console.WriteLine("- They pretend to be trusted companies (banks, PayPal, etc.)");
                Console.WriteLine("- They may send fake emails, SMS, or links");
                Console.WriteLine("- Always check URLs and never click suspicious links");
                Console.WriteLine("- Do not share passwords or OTPs");
            }

            // bot purpose
            else if (userInput.Contains("what are you") || userInput.Contains("what can i ask you") || userInput.Contains("what's your purpose"))
            {
                Console.WriteLine("Bot: I am a cybersecurity awareness assistant.");
                Console.WriteLine("- I explain security concepts");
                Console.WriteLine("- I help you stay safe online");
                Console.WriteLine("- You can ask about threats, tools, and best practices");
            }

            // thanks
            else if (userInput.Contains("thank you") || userInput.Contains("thanks"))
            {
                Console.WriteLine("Bot: You are welcome!");
                Console.WriteLine("Bot: Is there anything else I can help you with?");
            }

            // yes response
            else if (userInput.Contains("yes"))
            {
                Console.WriteLine("Bot: Great! Please enter your question.");
            }

            // malware
            else if (userInput.Contains("malware"))
            {
                Console.WriteLine("Bot: Malware is malicious software designed to harm systems.");
                Console.WriteLine("- Examples: viruses, worms, trojans, ransomware");
                Console.WriteLine("- Can steal data or damage files");
                Console.WriteLine("- Avoid downloading from unknown sources");
            }

            // cybersecurity importance
            else if (userInput.Contains("cybersecurity matters"))
            {
                Console.WriteLine("Bot: Cybersecurity protects your digital life.");
                Console.WriteLine("- Protects personal data and identity");
                Console.WriteLine("- Prevents financial loss");
                Console.WriteLine("- Keeps systems running safely");
            }

            // firewall
            else if (userInput.Contains("firewall"))
            {
                Console.WriteLine("Bot: A firewall controls network traffic.");
                Console.WriteLine("- Blocks unauthorized access");
                Console.WriteLine("- Can be hardware or software");
                Console.WriteLine("- Acts as a barrier between trusted and untrusted networks");
            }

            // ransomware
            else if (userInput.Contains("ransomware"))
            {
                Console.WriteLine("Bot: Ransomware locks your files and demands payment.");
                Console.WriteLine("- Usually spread via email attachments or downloads");
                Console.WriteLine("- Never pay ransom (no guarantee of recovery)");
                Console.WriteLine("- Always keep backups of important files");
            }

            // patching
            else if (userInput.Contains("patching"))
            {
                Console.WriteLine("Bot: Patching means updating software.");
                Console.WriteLine("- Fixes bugs and vulnerabilities");
                Console.WriteLine("- Helps prevent attacks");
                Console.WriteLine("- Always keep apps and OS updated");
            }

            // antivirus
            else if (userInput.Contains("antivirus software"))
            {
                Console.WriteLine("Bot: Antivirus protects your system.");
                Console.WriteLine("- Scans and removes malware");
                Console.WriteLine("- Provides real-time protection");
                Console.WriteLine("- Keep it updated for best results");
            }

            // VPN
            else if (userInput.Contains("virtual private network") || userInput.Contains("vpn"))
            {
                Console.WriteLine("Bot: A VPN secures your internet connection.");
                Console.WriteLine("- Encrypts your data");
                Console.WriteLine("- Hides your IP address");
                Console.WriteLine("- Useful on public Wi-Fi");
            }

            // data breach
            else if (userInput.Contains("data breach"))
            {
                Console.WriteLine("Bot: A data breach exposes sensitive information.");
                Console.WriteLine("- Can include passwords, emails, banking info");
                Console.WriteLine("- Use strong passwords");
                Console.WriteLine("- Enable 2-factor authentication");
            }

            // social engineering
            else if (userInput.Contains("social engineering"))
            {
                Console.WriteLine("Bot: Social engineering tricks people into giving info.");
                Console.WriteLine("- Uses manipulation and trust");
                Console.WriteLine("- Examples: phishing, impersonation");
                Console.WriteLine("- Always verify identity before sharing info");
            }

            // virus
            else if (userInput.Contains("virus"))
            {
                Console.WriteLine("Bot: A virus spreads by attaching to files.");
                Console.WriteLine("- Activates when file is opened");
                Console.WriteLine("- Can corrupt or delete data");
                Console.WriteLine("- Use antivirus protection");
            }

            // encryption
            else if (userInput.Contains("encryption"))
            {
                Console.WriteLine("Bot: Encryption protects data by converting it into code.");
                Console.WriteLine("- Only authorized users can read it");
                Console.WriteLine("- Used in banking and messaging apps");
                Console.WriteLine("- Keeps data safe from hackers");
            }

            // general cybersecurity
            else if (userInput.Contains("cybersecurity"))
            {
                Console.WriteLine("Bot: Cybersecurity protects systems and data.");
                Console.WriteLine("- Includes tools, policies, and practices");
                Console.WriteLine("- Protects against cyberattacks");
                Console.WriteLine("- Important for individuals and companies");
            }

            // passwords (NEW)
            else if (userInput.Contains("password"))
            {
                Console.WriteLine("Bot: Strong passwords are important.");
                Console.WriteLine("- Use at least 8-12 characters");
                Console.WriteLine("- Include numbers, symbols, and uppercase letters");
                Console.WriteLine("- Do not reuse passwords");
            }

            // 2FA (NEW)
            else if (userInput.Contains("2fa") || userInput.Contains("two factor"))
            {
                Console.WriteLine("Bot: Two-factor authentication adds extra security.");
                Console.WriteLine("- Requires password + second verification");
                Console.WriteLine("- Example: OTP or fingerprint");
                Console.WriteLine("- Strongly recommended for all accounts");
            }

            // greetings
            else if (userInput.Contains("hi") || userInput.Contains("hello") || userInput.Contains("hey") || userInput.Contains("good morning") || userInput.Contains("good afternoon"))
            {
                Console.WriteLine("Bot: Hello " + userName + ", how can I help you?");
            }

            // exit
            else if (userInput.Contains("exit") || userInput.Contains("no"))
            {
                Console.WriteLine("Bot: Thank you for your time. Stay safe online!");
                break;
            }

            // unknown input
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: I don't understand what you are saying " + userName + ", can you please type again.");
                Console.ResetColor();
            }
        }

    }

    public static void logo()
    {
        String logo =(@"                      ▓▓                  
                                          ████▒▒████              
                                    ██████▒▒▒▒▒▒▒▒▒▒██████        
                            ████████▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████
                            ██░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░██
                            ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
                            ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
                            ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
                            ██▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒██
                            ██▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒██
                            ██▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒██
                              ██▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒░░░░░░░░▒▒▒▒██  
                              ██▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒░░░░░░░░▒▒▒▒██  
                              ██▒▒▒▒▒▒░░░░░░░░▒▒░░░░░░░░▒▒▒▒░░██  
                              ▒▒▓▓▒▒▒▒░░░░░░░░▒▒░░░░░░░░▒▒▒▒▓▓▒▒  
                                ██▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒██    
                                  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██      
                                  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒██      
                                    ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░██        
                                      ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒██          
                                        ████▒▒▒▒▒▒████            
                                            ██████                

    

                          ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
                          ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
                          ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
                          ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
                          ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
                           ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

                           ███████╗███████╗ ██████╗██╗   ██╗██████╗ 
                           ██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗
                           ███████╗█████╗  ██║     ██║   ██║██████╔╝
                           ╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗
                           ███████║███████╗╚██████╗╚██████╔╝██║  ██║
                           ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝


");



        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(logo);
        Console.ResetColor();
    }
}
