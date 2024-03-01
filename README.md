# Spreadex Widgets

This project is a coding exercise, which is  to be assessed by Spreadex as required for the job application process.

## Make Commands
- `make` - Builds and runs `SpreadexWidgets.Tests`.
- `make run` - Builds and runs the `SpreadexWidgets` Application via the `Program.Main` entrypoint.
- `make test` - Builds and runs `SpreadexWidgets.Tests`.
- `make clean` - Cleans the output of the previous build.

## Design Decisions

### Widgets

The Coding Exercise document states that `Widths, heights and diameters must be positive`. In order to satisfy this requirement, I started by writing tests for the validation of the dimensions. The end result is a set of tests for the Widgets that expect an `ArgumentOutOfRangeException` to be thrown when a dimension is negative. 

The base class, Widget, specifies properties such as PositionX, PositionY, and Width, which are all used by two or more subclasses.

After identifying that `Rectangle` and `Textbox` have properties in common, I decided to extend the Rectangle class in the Textbox class definition.

### Rendering

To simulate the drawing package, I decided to create the `IRenderer` interface, which made it possible to offload the responsibility of rendering Widgets to some external implementation.

My plan for the `TextRenderer` class implementation was to define a  buffer, for the Widgets to be written to prior to rendering them to a Stream source. After some tweaking, I was able to get it to produce simulated renders, with abstraction in mind.

#### Usage:

```
            IRenderer renderer = new TextRenderer();

            renderer.DrawRectangle(new Rectangle(10, 10, 30, 40));

            using Stream stream = new MemoryStream();
            renderer.Render(stream);

            using (StreamReader reader = new StreamReader(stream))
            {
                stream.Seek(0, SeekOrigin.Begin);
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
```

### Versioning

Talk about versioning for the renderers, to add a new version in future that supports more widgets

### IDisposable

Talk about why I used IDisposable, and what benefits it provides me with.

### Buffer Solution

Talk about why I chose to use a fixed size byte[] over a MemoryStream

### Exceptions

Talk about the different exceptions thrown, and how I tested them.
Also include information about the text orientation here.

## Future work

### Exclude frames from TextRenderer

Talk about why you would spend more time isolating the frames from the text renderer

### Output to file

Talk about adding support to output to file

### Additional Widgets

Talk about adding additional widgets, such as hexagons, or triangles

### Improvement to Textbox Construction

Talk about how you would consider using a builder, or config object, to make it more convenient to construct 