# .NET Hosted Service with Clean Architecture & Apache Kafka

## Overview
Production-style .NET background processing example combining a Hosted Service/BackgroundService, Apache Kafka and Clean Architecture principles.

## Architecture
```text
Kafka Broker -> .NET Hosted Service / BackgroundService -> Application -> Domain / Infrastructure
```

## Key Features
- Long-running .NET background worker
- Apache Kafka message consumption
- Clean Architecture boundaries
- Dependency Injection
- Event-driven asynchronous processing
- Separation of business logic from infrastructure

## Why It Matters
Enterprise platforms often need to process events independently from HTTP requests. Hosted Services provide a natural .NET worker model, while Kafka provides event streaming and producer/consumer decoupling.

## Step-by-Step Flow
1. A producer publishes an event to Kafka.
2. The .NET Hosted Service starts with the application lifecycle.
3. The Kafka consumer receives events continuously.
4. Application-layer logic processes the event.
5. Domain logic remains independent of Kafka-specific infrastructure.
6. Infrastructure components handle external integrations.

## Technology Stack
`C#` `.NET` `Hosted Service` `BackgroundService` `Apache Kafka` `Clean Architecture` `Dependency Injection` `Event-Driven Architecture`

## LinkedIn Project Description
**Built a production-style .NET background processing service using Apache Kafka and Clean Architecture, focusing on event-driven processing, separation of concerns, dependency injection and scalable asynchronous workloads.**

## Recommended Enhancements
- Retry/backoff and dead-letter handling
- OpenTelemetry metrics/tracing
- Structured logging
- Consumer health checks
- Integration tests
- Docker/Kafka local environment
- CI/CD automation

## Repository
https://github.com/NaraP/.NET-Hosted-Service-with-Clean-Architecture-with-KAFKA
