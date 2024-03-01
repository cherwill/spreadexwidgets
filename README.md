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

### Rendering Interface

To simulate the drawing package, I decided to create the `IRenderer` interface, which made it possible to offload the responsibility of rendering Widgets to some external implementation.

With this design in mind, we aren't imposing too many limitations on how other renderers can be implemented.

### Text Rendering

My plan for the `TextRenderer` class implementation was to define a  buffer, for the Widgets to be written to prior to rendering them to a Stream source. After some tweaking, I had the Text Renderer producing simulated renders, whilst having a layer of abstraction present.

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

In circumstances where we decide to make substantial changes to the Renderer, we can release a new version, V2, and mark V1 as `deprecated`.

This way, we can provide new functionality for those who are looking to adopt the new changes, whilst providing support for existing users of V1 Renderers. 

### IDisposable

Implementing IDisposable for TextRenderer seemed like a justified decision, since this class makes use of a buffer to keep track of the Widgets that have been drawn.

IDisposable enforces us to implement Dispose, which provides us with a good opportunity to close the buffer.

### Buffer Solution

When a draw request takes place, the shape is pre-rendered by storing the draw data in the buffer.

For this, I chose to use a MemoryStream, as it provides the facility of dynamic sizing. 

### Exceptions

When trying to draw a Textbox using an unsupported orientation, a `NotSupportedException` is thrown, with a message which mentions the orientation in question.

Widgets provided with a negative dimension will throw a `ArgumentOutOfRangeException`, with a message which mentions the dimension is question.

## Future work

### Exclude frames from TextRenderer

I would have liked to have moved the responsibility of rendering the frame header and footer outside of the text renderer. 

When testing `TextRendererTests`, we shouldn't be concerned with testing the frame header and footer amongst the resulting stream. However, in the current implementation, but we are forced to take this into account due to the nature of how the text is rendered.

### Output to file

Given the current implementation of how text is rendered, I would be interested in adapting it to output render data to file.

### Additional Widgets

Shapes, such as a hexagon or triangle, with rendering support from a V2 Renderer, would be an interesting challenge for me to solve.

### Improvement to Textbox Construction

After spending some time reflecting on my work, the Textbox constructor looks like it accepts too many arguments. I would be interested in tidying this up by exploring alternative methods of initializing the object. 

Builder pattern and parameter objects are just a couple of ideas that come to mind. 