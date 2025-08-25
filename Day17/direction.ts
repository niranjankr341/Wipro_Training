enum Direction { Up = 1, Down, Left, Right }

function move(dir: Direction) {
    switch(dir) {
        case Direction.Up: console.log("Moving Up"); break;
        case Direction.Down: console.log("Moving Down"); break;
        case Direction.Left: console.log("Moving Left"); break;
        case Direction.Right: console.log("Moving Right"); break;
    }
}

move(Direction.Left);
move(Direction.Up);
