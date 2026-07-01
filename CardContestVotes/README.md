# CardContestVotes
This repository houses the calculator made for Fanscryption's Card Contests, which helps automate the math needed to determine placings.

This is released as Open-Source subject to the terms found within [SML-1.0.0](https://stoatgames.icu/license-repository/licenses/sml-1-0-0/#content)

## Credits:
* Chaosyr: Creation of the Code.
* Cecil Libraries Organization: The underlying Library handling the ANSI Utilities, called `Cecil.ANSI_Utils`, it is licensed under [CLL-1.0.0](https://stoatgames.icu/license-repository/licenses/cll-1-0-0/#content) and [SML-1.0.0](https://stoatgames.icu/license-repository/licenses/sml-1-0-0/#content), the full License, Docs and everything else can be found on [Stoat Games: Cecil Libraries Organization: Cecil.ANSI_Utils](https://stoatgames.icu/subsidiaries/cecil-libraries-organization/projects/cecil-ansi-utils/#header-container-subsite-project)

## How To Utilize and Modify:

### Setup:

Configuring will require either Forking or Downloading this repository, rather than installing a release directly (at least for the versions where this text is present.)

1. Install or have any of the following Runtimes/Frameworks or OS's in the form of a DeveloperKit, if you have none the newest (non-prerelease) is reccomended:
    1. Operating Systems
        1. win-x64
        2. win-x86
        3. win-arm64
        4. linux-x64
        5. linux-arm
        6. linux-arm64
        7. linux-musl-x64
        8. linux-musl-arm64
        9. osx-x64 (MacOS)
    2. Runtimes/Frameworks
        1. netframework4.7.2
        2. netframework4.8
        3. netframework4.8.1
        4. net5.0
        5. net6.0
        6. net7.0
        7. net8.0
        8. net9.0
        9. net10.0
2. If you plan (like most) to modify the application to modify the score values, you will need an IDE (Integrated Development Environment) the following are some known and reccomended IDE's:
    1. [JetBrains Idea](https://www.jetbrains.com/rider/)
    2. [Visual Studio](https://visualstudio.microsoft.com/)
    3. [Visual Studio Code](https://code.visualstudio.com/)
    4. Or alternatively you could edit `Class1.cs` in a text editor than run `TS-Build.bat`, keep in mind the script is built for Windows specifically, and runs through every framework and OS. Output will appear in ZIPS as seen in the Releases section on the GitHub.
        1. OR if you don't want less waiting execute the following commands in Powershell or your Terminal.
           1. `cd "{The Directory this Repository was installed into}"`, if your on windows you can grab the path from the File Explorer Address Bar.
           2. `dotnet build`
           3. Files will be in `bin/{release or debug, terminal should specifiy}/{framework}` than you can just run the executable to test.
3. Edit the `Class1.cs` file to calculate the score however you wish, the main score equation is handled in the foreach entry loop at the end of the file. If you want to do something more advanced feel free to do so, we made sure to link out to `Cecil.ANSI_Utils` docs for that purpose.
4. Open `CardContestVotes.csproj` and update the Description and AssemblyName to match your purposes (also the TS-Description and name too). Remove the below code from `NuGet.config`, or replace the value with where you want NUGET sending your packages. DO NOT TOUCH ANYTHING ELSE UNLESS YOU KNOW WHAT YOUR DOING.
    1. ```xml
        <config>
            <add key="globalPackagesFolder" value="D:\Nuget" />
        </config>
       ```
5. Build the project with your preferred Build System.
6. Now within the Debug/Release of the bin you will find the updated Terminal Application, you can go into a framework and run it via the Executable created during build time.

### Running:

1. Run the target Executable.
2. Enter values based on whats asked, we have error handling for the case things fail, don't worry!!

## How you can support our Projects and their Developers:

* You can donate to Chaosyr (The Primary Developer in this case) here:
    * Use code `Chaosyr` in Hytale Checkout, they will receive a portion of the Checkout proceeds.
    * Use their KO-FI and donate or commission: https://ko-fi.com/thincreator3483
* You can help Financially Support Stoat Games here:
    * Use our affiliate link with IONOS: https://aklam.io/thGxWQTD (This is the most powerful method for keeping The Docs site alive.)
    * Use our affiliate link with The Free Website Guys: https://thefreewebsiteguys.com/?js=a16638001b (Less powerful but it will support The Docs Site, and them)
    * When the Option opens you can choose US to host your Projects Docs or Your Organizations Subsite under [Stoat Games](https://stoatgames.icu)
* Contribute to our Projects
    * You can send Pull Requests to any of our Projects to help make them work better for future users.
    * You can submit Bug Reports so that we can help More Users have a better time with our Projects.
    * You can Translate our Project [Stoat Games](https://stoatgames.icu).
    * You can Contribute to the Project [Stoat Games](https://stoatgames.icu) by shooting us emails with Feedback and better code.

# LICENSED UNDER [SML-1.0.0](https://stoatgames.icu/license-repository/licenses/sml-1-0-0/#content)