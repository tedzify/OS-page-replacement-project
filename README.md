# OS-page-replacement-project

A Windows Forms application for simulating and visualizing various page replacement algorithms used in operating systems.

## Features

- **Multiple Algorithms**: Supports simulation of common page replacement algorithms (e.g., FIFO, LRU, Optimal).
- **Interactive UI**: User-friendly Windows Forms interface for inputting page reference strings and frame sizes.
- **Visualization**: Step-by-step visualization of page replacement process.
- **Statistics**: Displays page faults and hit/miss statistics.
- **Modular Design**: Core logic separated into algorithms, models, and utilities for easy extension and testing.
- **Unit Tests**: Includes a test project for validating algorithm correctness.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Windows OS

### Build and Run

1. Clone the repository:```sh
git clone https://github.com/yourusername/OS-page-replacement-project.git
    cd OS-page-replacement-project
```2. Build the project:```sh
dotnet build
```3. Run the application:```sh
dotnet run --project OS-page-replacement-project.csproj
```
## Usage

- Launch the application.
- Enter the page reference string and number of frames.
- Select the desired page replacement algorithm.
- Click "Simulate" to view the step-by-step process and statistics.

## Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements.

## License

[MIT](LICENSE)
