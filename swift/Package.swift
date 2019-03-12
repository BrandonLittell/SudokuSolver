// swift-tools-version:4.2

import PackageDescription

let package = Package(
    name: "SudokuSolver",
    products: [
        .library(
            name: "SudokuSolver",
            targets: ["SudokuSolver"]),
    ],
    dependencies: [],
    targets: [
        .target(
            name: "SudokuSolver",
            dependencies: []),
        .testTarget(
            name: "SudokuSolverTests",
            dependencies: ["SudokuSolver"]),
    ]
)
