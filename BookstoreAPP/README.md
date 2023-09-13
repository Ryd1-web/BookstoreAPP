# Online Bookstore Application Setup Guide

This guide provides instructions for setting up and running the Online Bookstore application. The application consists of various services, including the Order Processing and Inventory Management services, which communicate through RabbitMQ, and a REST API for managing books and orders.

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Setting Up RabbitMQ](#setting-up-rabbitmq)
3. [Building Docker Containers](#building-docker-containers)
4. [Running the Services](#running-the-services)
5. [Using the API](#using-the-api)
6. [Additional Configuration](#additional-configuration)

## Prerequisites
Before getting started, make sure you have the following prerequisites installed:
- [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet) for building and running the application.
- [Docker](https://www.docker.com/get-started) for containerization.

## Setting Up RabbitMQ
1. Install RabbitMQ on your local machine or a server. You can download it from [here](https://www.rabbitmq.com/download.html) and follow the installation instructions.
2. Start the RabbitMQ server.

## Building Docker Containers
1. Clone this repository to your local machine:

    ```bash
    git clone <repository-url>
    cd online-bookstore
    ```

2. Build Docker containers for the services. Run the following command from the project root:

    ```bash
    docker-compose build
    ```

## Running the Services
1. Start the Docker containers:

    ```bash
    docker-compose up -d
    ```

2. The services should now be running in separate containers. You can check the logs for each service using:

    ```bash
    docker-compose logs <service-name>
    ```

## Using the API
The Online Bookstore API provides several endpoints for managing books and orders. You can access the API at `http://localhost:5000` (or the appropriate address if running on a server).

### Sample API Requests
- **Fetching the list of books**:
  - Endpoint: `GET http://localhost:5000/api/books`
- **Fetching book details by ID**:
  - Endpoint: `GET http://localhost:5000/api/books/{id}`
- **Placing an order**:
  - Endpoint: `POST http://localhost:5000/api/orders`
  - Request Body (JSON):
    ```json
    {
        "userId": 1,
        "bookId": 2,
        "quantity": 3
    }
    ```
- **Fetching order status by ID**:
  - Endpoint: `GET http://localhost:5000/api/orders/{orderId}`

## Additional Configuration
- You can customize the application's configuration by modifying the `appsettings.json` file in each service's project.
- Ensure that the RabbitMQ connection settings in `appsettings.json` match your RabbitMQ server configuration.
- Environment variables may be required for specific configurations in a production environment. Consult the service documentation for details.
