# kubernets-on-azure
A demo application (Api asp.net core, Angular SPA, MysqlBackend) to learn how to use Kubernetes on Microsoft Azure

# Why this application?
I need this to get some simple service to support my tutorial on Kubernetes and docker. You can find it here to understand what I've done:
- [What is exactly Kubernetes?](https://towardsdatascience.com/what-exactly-is-kubernetes-52c9f1c4990b)
- [How to Deploy a Web Application with Kubernetes](https://medium.com/swlh/how-to-deploy-an-asp-net-application-with-kubernetes-3c00c5fa1c6e)

# What is this demo?
This project contains an asp.net web api application that serves backend functionalities for the angular heroes tutorial. This application is a simple CRUD on heroes and allow you to manage a list of your favourite heoroes. Sorry if this doesn't seems to clever, but it's just 
a demo!

# How it works?
The backend was implemented by providing same json format that the angular demo expects. The frontend is quite the same from the original angular demo. Basically, there is 3 different container:
- a mysql instance (data folder mapped to an external folder)
- an asp.net web api backend
- an angular fronted


