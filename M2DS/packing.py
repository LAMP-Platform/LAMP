from typing import List, Tuple, Optional

# Define the shape as a list of tiles (relative positions of tiles)
Shape = List[Tuple[int, int]]  # Each tile is represented by a (x, y) offset

# ANSI color codes for the console
COLORS = [
    "\033[41m",  # Red
    "\033[42m",  # Green
    "\033[43m",  # Yellow
    "\033[44m",  # Blue
    "\033[45m",  # Magenta
    "\033[46m",  # Cyan
    "\033[47m",  # White
    "\033[100m", # Gray
]

RESET = "\033[0m"  # Reset color

def pack_shapes(bin_size: int, shapes: List[Shape]) -> Optional[Tuple[List[Tuple[int, int]], List[List[int]]]]:
     # Sort shapes by tile count in descending order
    shapes = sorted(shapes, key=len, reverse=True)

    # Initialize the grid as a bin_size x bin_size grid with -1 (empty cell)
    grid = [[-1] * bin_size for _ in range(bin_size)]
    placements = []  # To store the top-left positions of placed objects

    # Check if a shape can be placed at a given (x, y) position
    def can_place(x: int, y: int, shape: Shape) -> bool:
        for dx, dy in shape:
            gx, gy = x + dx, y + dy
            if gx < 0 or gy < 0 or gx >= bin_size or gy >= bin_size or grid[gy][gx] != -1:
                return False
        return True

    # Place the shape at a given (x, y) position
    def place_shape(x: int, y: int, shape: Shape, shape_index: int):
        for dx, dy in shape:
            grid[y + dy][x + dx] = shape_index
        placements.append((x, y))

    # Remove the shape from the grid at a given (x, y) position
    def remove_shape(x: int, y: int, shape: Shape):
        for dx, dy in shape:
            grid[y + dy][x + dx] = -1
        placements.pop()

    # Try placing all shapes using backtracking
    def try_place_shapes(index: int) -> bool:
        if index == len(shapes):
            return True  # All shapes placed

        shape = shapes[index]
        for y in range(bin_size):
            for x in range(bin_size):
                if can_place(x, y, shape):
                    place_shape(x, y, shape, index)
                    if try_place_shapes(index + 1):
                        return True
                    remove_shape(x, y, shape)
        return False

    # Start placing the shapes
    if try_place_shapes(0):
        return placements, grid
    return None  # Packing failed


def display_colored_grid(grid: List[List[int]]):
    for row in grid:
        for cell in row:
            if cell == -1:
                print(" . ", end="")  # Placeholder for empty cells
            else:
                color = COLORS[cell % len(COLORS)]  # Cycle through colors
                print(f"{color}{cell:2}{RESET} ", end="")  # Proper padding
        print()  # New line after each row


shapes: List[Shape] = [
    # Massive boxy shapes

    # 10x6 rectangle (60 tiles)
    [(x, y) for x in range(10) for y in range(6)],

    # 5x12 rectangle (60 tiles)
    [(x, y) for x in range(5) for y in range(12)],

    # Large "C" shape (50 tiles: 7x7 with a hollow center)
    [(x, y) for x in range(7) for y in range(7) if not (1 <= x <= 5 and 1 <= y <= 5)],

    # Basic shapes
    [(0, 0)],  # Single tile
    [(0, 0), (1, 0)],  # Horizontal line (2 tiles)
    [(0, 0), (0, 1)],  # Vertical line (2 tiles)

    # Rectangles
    [(0, 0), (1, 0), (0, 1), (1, 1)],  # Square (2x2)
    [(0, 0), (1, 0), (2, 0), (3, 0)],  # Horizontal line (4 tiles)
    [(0, 0), (0, 1), (0, 2), (0, 3)],  # Vertical line (4 tiles)

    # L-shapes
    [(0, 0), (1, 0), (0, 1)],  # Small "L" shape (3 tiles)
    [(0, 0), (1, 0), (2, 0), (0, 1)],  # Larger "L" shape (4 tiles)

    # T-shapes
    [(0, 0), (1, 0), (2, 0), (1, 1)],  # T-shape (4 tiles)

    # Z-shapes
    [(0, 0), (1, 0), (1, 1), (2, 1)],  # Z-shape (4 tiles)
    [(1, 0), (2, 0), (0, 1), (1, 1)],  # Reverse Z-shape (4 tiles)

    # Complex shapes
    [(0, 0), (1, 0), (0, 1), (1, 1), (1, 2)],  # "Boot" shape (5 tiles)
    [(0, 0), (1, 0), (1, 1), (1, 2), (2, 1)],  # Cross shape (5 tiles)
    [(0, 0), (1, 0), (2, 0), (1, 1), (1, 2)],  # Arrowhead shape (5 tiles)
    [(0, 0), (1, 0), (2, 0), (2, 1), (3, 1)],  # Hook shape (5 tiles)

    # Large shapes
    [(0, 0), (1, 0), (2, 0), (3, 0), (4, 0)],  # Long horizontal line (5 tiles)
    [(0, 0), (0, 1), (0, 2), (0, 3), (0, 4)],  # Long vertical line (5 tiles)
    [(0, 0), (1, 0), (2, 0), (3, 0), (3, 1)],  # L-shape with longer stem (5 tiles)

    # Basic shapes
    [(0, 0)],  # Single tile
    [(0, 0), (1, 0)],  # Horizontal line (2 tiles)
    [(0, 0), (0, 1)],  # Vertical line (2 tiles)

    # Rectangles
    [(0, 0), (1, 0), (0, 1), (1, 1)],  # Square (2x2)
    [(0, 0), (1, 0), (2, 0), (3, 0)],  # Horizontal line (4 tiles)
    [(0, 0), (0, 1), (0, 2), (0, 3)],  # Vertical line (4 tiles)
]

shapes = [
    [(1, 0), (2, 0), (3, 0), (4, 0), (5, 0), (6, 0), (7, 0), (8, 0),
    (9, 0), (0, 1), (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1),
    (7, 1), (8, 1), (9, 1), (0, 2), (1, 2), (2, 2), (3, 2), (8, 2),
    (9, 2), (0, 3), (1, 3), (8, 3), (9, 3), (0, 4), (1, 4), (8, 4),
    (9, 4)],

    [(3, 0), (4, 0), (5, 0), (6, 0), (7, 0), (8, 0), (9, 0), (3, 1),
    (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (0, 2), (1, 2),
    (2, 2), (3, 2), (4, 2), (8, 2), (9, 2), (0, 3), (1, 3), (2, 3),
    (3, 3), (4, 3), (8, 3), (9, 3), (10, 3), (11, 3), (0, 4), (1, 4),
    (2, 4), (8, 4), (9, 4), (10, 4), (11, 4), (0, 5), (1, 5), (2, 5),
    (10, 5), (11, 5), (0, 6), (1, 6), (2, 6), (10, 6), (11, 6)],

    [(0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (1, 1), (2, 1), (3, 1),
    (0, 2), (1, 2), (2, 2), (3, 2), (0, 3), (3, 3), (0, 4), (3, 4),
    (0, 5), (3, 5), (0, 6), (3, 6), (0, 7), (3, 7), (0, 8), (3, 8),
    (4, 8), (0, 9), (3, 9), (4, 9), (0, 10), (3, 10), (4, 10), (0, 11),
    (3, 11), (4, 11), (0, 12), (3, 12), (4, 12), (0, 13), (3, 13),
    (4, 13), (0, 14), (3, 14), (4, 14), (0, 15), (3, 15), (4, 15)],

    [(3, 0), (4, 0), (5, 0), (6, 0), (7, 0), (1, 1), (2, 1), (3, 1),
    (4, 1), (5, 1), (6, 1), (7, 1), (0, 2), (1, 2), (2, 2), (3, 2),
    (4, 2), (7, 2), (0, 3), (1, 3), (3, 3), (4, 3), (7, 3), (0, 4),
    (1, 4), (3, 4), (4, 4), (7, 4), (0, 5), (7, 5)],
]

# Run the algorithm
result = pack_shapes(16, shapes)

# Output results
if result:
    placements, grid = result
    print("Shapes placed successfully at the following positions:")
    for shape_index, pos in enumerate(placements):
        print(f"Shape {shape_index} placed at position: {pos}")

    print("\nFinal grid (color-coded):")
    display_colored_grid(grid)
else:
    print("Failed to pack all shapes.")