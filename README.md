# Deploying a Local C# API to Kubernetes with Minikube and Docker

This project demonstrates a C# API deployed to Kubernetes with both Liveness and Readiness Probes implemented for health checking.

It is part of a tutorial series to showcase different Kubernetes health check features and strategies for maintaining application stability and availability.

## Features:

- Liveness Probe: Ensures that the container is restarted if it becomes unhealthy.
- Readiness Probe: Ensures that traffic is only routed to containers that are ready to handle requests.

## Prerequisites

- Minikube installed and running
- Docker installed
- Kubectl installed
- .NET SDK installed

### Project Structure

```c#
LocalCSharpK8sAPI/
├── IaC/
│   ├── deployment.yaml                     # Deployment manifest (for basic app)
│   ├── deployment2.yaml                    # Deployment manifest (second version)
│   ├── deployment3.yaml                    # Deployment manifest with health checks
│   ├── service.yaml                        # Service to expose the app
│   ├── service2.yaml                       # Another service file (second version)
│   ├── service3.yaml                       # Service for the health check demo
├── src/
│   ├── K8sTimeService.sln                  # C# Solution
│   ├── K8sTimeService.API/
│   │   ├── Dockerfile                      # Dockerfile for containerizing the API
│   │   ├── HealthCheckController.cs        # Handles health check endpoint
│   │   ├── TimeController.cs               # Provides the time-related functionality
│   │   ├── Program.cs                      # Application startup
│   │   ├── appsettings.json                # Configuration file
│   │   ├── appsettings.Development.json    # Dev-specific config
├── README.md                               # This documentation file


```

More details:
- <a href="https://jafreitas90.medium.com/health-checks-in-kubernetes-part-1-managing-traffic-flow-with-liveness-dc44b6136081" target="_blank">Part 1</a>
- <a href="https://jafreitas90.medium.com/health-checks-in-kubernetes-part-2-managing-traffic-flow-with-readiness-ba1781069387" target="_blank">Part 2</a>



