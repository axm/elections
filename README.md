# Project Spartan (Elections system)
## Overview
Project Spartan is an implementation of an election-management system. The main objective is to develop a solution that implements modern architectural patterns and that would provide a scalable and reliable experience if it were deployed in a live scenario.

Currently the model that heavily influences the design is the US Presidential Election, however at many levels decisions were made such that the system would be able to include other election models such as general elections (both in the US or abroad), referendums or other types of elections.

The system offers both inbound (via an API) and outboud (via webhooks) communication.

## Current state
Currently my efforts focus on building the core voting pipeline: API -> Voting Service -> US Voting Service -> ... -> Precinct actor

Part of this includes writing utilities for communicating via with RabbitMq, serializing/deserializing data or using Azure Blob Storage.

## Tech stack
* .NET Standard & .NET Core
* Angular 6+
* ASP.NET Core
* Azure Service Fabric
* Azure Blob Storage
* RabbitMQ (via Docker)
* Redis (via Docker)
