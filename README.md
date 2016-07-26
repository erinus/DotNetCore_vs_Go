# .Net Core vs. Go
  
Virtual Machines runs by VMware Workstation 12.1.1 build-3770994 on Windows 10 x64  
  
<b>Host Environment</b>  
>Board: Supermicro MBD-X10DAI-O  
>CPU: Intel Xeon E5-2630 V3, 2.4GHz, 20MB Cache  
>RAM: 64GB (Samsung 16GB DDR4-2133 ECC REG * 4)  
>RAID: LSI9260-8i  
>HDD: RAID10 - 8TB (TOSHIBA MD03ACA400V, 4TB, 7200RPM, 64M, SATAIII * 4)  
>OS: Microsoft Windows 10 Enterprise x64
  
<b>Guest Environment: .NET Core & Go</b>  
>Processors: 4 (1 processors, 4 cores)  
>Memory: 4GB  
>Hard Disk (SCSCI): 64GB  
>Network Adapter: NAT  
>OS: Ubuntu Server 16.04 x64  
>Software: Microsoft .NET Core 1.0.1 (Build cee57bf6c981237d80aa1631cfe83cb9ba329f12)  
>Software: Google Go 1.6.3   
  
<b>Guest Environment: Apach JMeter</b>  
>Processors: 4 (1 processors, 4 cores)  
>Memory: 4GB  
>Hard Disk (SCSCI): 64GB  
>Network Adapter: NAT  
>OS: Ubuntu Desktop 14.04.4 x64  
>Software: Apache JMeter 3.0  
  
  
  
<b>Case 01: Output Static JSON</b>  
.NET Core:  
>Throughput: 16300  
>KB/sec: 2833  
Go  
>Throughput: 21203  
>KB/sec: 2961  
  
<b>Case 02: Output Static JSON (add 1000 times Random Number into List)</b>  
|               | .NET Core (List) | Go (use slice) | Go (use list) |
| ------------- | ----------------:| --------------:| -------------:|
| Throughput    |            16901 |           6252 |         21203 |
| KB/sec        |             2360 |            873 |          2961 |
  
<b>Case 03: Output HTML by Built-in Template</b>  
