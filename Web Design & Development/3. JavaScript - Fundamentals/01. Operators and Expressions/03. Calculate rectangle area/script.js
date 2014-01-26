/*
    3. Write an expression that calculates rectangle�s
    area by given width and height.
*/

taskName = "3. Calculate rectangle area";

function Main(bufferElement) {

    var width = ReadLine("Enter width: ", GetRandomFloat(0, 10));
    var height = ReadLine("Enter height: ", GetRandomFloat(0, 10));

    SetSolveButton(function () {
        ConsoleClear();
        WriteLine(Format("Rectangle area: {0} units", CalculateRectancleArea(width.value, height.value).toFixed(4)));
    });
}

function CalculateRectancleArea(width, height) {
    width = parseFloat(width);
    height = parseFloat(height);

    if (Number.isNaN(width) || Number.isNaN(height)) {
        WriteLine("Error! There is some incorrect input value!");
        return;
    }

    return width * height;
}
