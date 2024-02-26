# **RabbitMQ**

This a RabbitMQ implementation using c#

## _Requirements_
Follow the download and installation instructions in the link below from the official site 
https://www.rabbitmq.com/docs/download


## _Troubleshooting_
1. After installation and you try to browse the management url (http://127.0.0.1:15672/) and it fails to load, you need to enable rabbitmq management
	- windows: run the command below by opening #RabbitMQ Command Prompt (sbin dir)
		rabbitmq-plugins.bat enable rabbitmq_management
		
	- run the command below to check that these services (rabbitmq_management, rabbitmq_management_agent, rabbitmq_web_dispatch) are enabled. E or e will be in a bracket e.g. [E ] or [e ]
		rabbitmq-plugins.bat list
		
2 Stop and Start the RabbitMQ Service. You caan give it some time like 5-10 seconds (based on my experience) after restart before reloading the URL


## _Tutorials_
Visit the link below for detailed steps and different scenarios
https://www.rabbitmq.com/tutorials


## _Note_
Below is the connection factory which allows you to connect to a RabbitMQ instance on a remote/different machine. The HostName is the IP Address, Username and Password should be different from the default username and password.
```C# 
	var factory = new ConnectionFactory { HostName = "", Port = 5672, UserName = "user", Password = "user" };
```