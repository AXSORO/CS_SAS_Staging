my first C# project that saw the light - 

this is a gui rendition of a powershell script i build for centralized, local server management 
for work, part of my job involves provisioning monitoring servers on customer networks, and not all engineers are very well versed with windows server configuration 
to combat this, and since a powershell script ended up being too complicated to operate, i decided a simple C# winforms app is my best bet to make it easier on everyone

this program utilizes default winforms assets, and some lightweight APIs and tools to keep file size and dependencies to a minimum 
this program when compiles is ~5.2mb (at the time of writing), and when published as a self contained app, will only be a single file
this is done since all functions are executed entirely within C# with some commands being called using powershell, invoked through Batch 


this is still a work in progress at the moment. i am sure something else like this exists and is more robust, but this is mainly just a learning process for me, as i have no prior high-level programming experience 

![image](https://github.com/AXSORO/CS_SAS_Staging/assets/124528095/0e98cac1-b28a-441b-aaa5-1f5a4032e964)

