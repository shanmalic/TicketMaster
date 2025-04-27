# Ticketmaster App

This is a .NET MAUI mobile app that integrates with the Ticketmaster Discovery API. It allows users to search for attractions, view event details, and discover upcoming events.

## Setup

To get started with the app, follow the steps below:

1. Open the solution in Visual Studio 2022:
   - Open `TicketMaster.sln` in Visual Studio 2022.

2. Set your Ticketmaster API key:
   - Navigate to `Services/TicketmasterService.cs`.
   - Set your API key within the file to enable the app to connect with the Ticketmaster API.

3. Deploy to an Android or iOS simulator/device:
   - Build and deploy the app to an Android or iOS simulator or physical device.

## Features

- **Search Attractions**: 
   - The app allows you to search for attractions, with "Phish" as the default search term.
   
- **View Details & Upcoming Events**: 
   - You can view detailed information about attractions, including their upcoming events.

## Notes

- Ensure you have a valid API key from Ticketmaster to use the API features.
- The app supports both Android and iOS platforms, leveraging .NET MAUI's cross-platform capabilities.
