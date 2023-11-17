my first C# project that saw the light 
this is a gui rendition of a powershell script i build for centralized, local server management 
for work, part of my job involves provisioning monitoring servers on customer networks, and not all engineers are very well versed with windows server configuration 
to combat this, and since a powershell script ended up being too complicated to operate, i decided a simple C# winforms app is my best bet to make it easier on everyone

this program utilizes default winforms assets, and only one external library: FirewallAPI (NetFwTyoeLib)
this program when compiles is ~300kb, and when published as a self contained app, will only be a single file
this is done since all functions are executed entirely within C#

there is only one extra c# class, which is to help with the organization of the networking information when displayed 

this is still a work in progress at the moment. i am sure something else like this exists and is more robust, but this is mainly just a learning process for me, as i have no prior high-level programming experience 

