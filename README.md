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

In circumstances where we decide to make substantial changes to the Renderer, we can release a new version, V2, and mark V1 as `deprecated`.

This way, we can provide new functionality for those who are looking to adopt the new changes, whilst providing support for existing users of V1 Renderers. 

### IDisposable

Implementing IDisposable for TextRenderer seemed a justified decision, since this class makes use of a buffer to keep track of what Widgets have been drawn.

IDisposable enforces us to implement Dispose, which provides us with a good opportunity to clear and reset the buffer.

### Buffer Solution

Talk about why I chose to use a fixed size byte[] over a MemoryStream

Initially for the TextRenderer, I chose to use a MemoryStream for the buffer. In order to reduce the memory consumption of the buffer, I decided to use a byte array instead. 

When a draw request takes place, the renderer checks buffer to see if it has the capacity to draw the widget. If the request is satisfied, the data is written to the buffer, and the bufferPosition is updated accordingly. 

The end result is a lightweight buffer solution with a configurable memory limit.

### Exceptions

Talk about the different exceptions thrown, and how I tested them.

In circumstances where there isn't enough remaining space in the buffer, an `OutOfMemoryException` is thrown, with a message that provides information for RequestedBytes vs RemainingBytes.

When trying to draw a Textbox using an unsupported orientation, a `NotSupportedException` is thrown, with a message which mentions the orientation in question.

Widgets provided with a negative dimension will throw a `ArgumentOutOfRangeException`, with a message which mentions the dimension is question.

Also include information about the text orientation here.

## Future work

### Exclude frames from TextRenderer

I would have liked to have moved the responsibility of rendering the frame header and footer outside of the text renderer. 

When testing TextRendererTests, we shouldn't be concerend with testing out with the frame header and footer. However, in the current implementation, but we are forced to take this into account due to the nature of how the text is rendered.

### Output to file

Given the current implementation of how text is rendered, I would be interested in adapting it to output render data to file.

### Additional Widgets

Additional widgets, such as a hexagon or triangle, with rendering support from a V2 Renderer, would be an interesting challenge for me to solve.

### Improvement to Textbox Construction

Talk about how you would consider using a builder, or config object, to make it more convenient to construct

After spending some time reflecting on my work, the Textbox constructor looks like it accepts too many arguments. I would be interested in tidying this up by exploring alternative methods of initializing the object. 

Builder pattern and parameter objects are just a couple of ideas that come to mind. 