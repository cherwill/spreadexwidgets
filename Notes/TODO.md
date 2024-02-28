What I need to do:

Create a console application which simulates a drawing package.
The application should support the following 5 drawing primitives / widgets:
- Rectangle
- Square
- Ellipse
- Circle
- Textbox

Requirements:

The application should allow widgets to be added to the drawing, stating the LOCATION and SIZE/SHAPE of the widget.

The Location can be a standard X/Y coordinate on an imaginary image. The size/shape depends on the widget as follows:
- Rectangle: width and height
- Square: width
- Ellipse: horizontal and vertical diameter
- Circle: diameter
- Textbox: Bounding rectangle ( The rectangle which surrounds the textbox; the text will be centered withini this rectangle)

Clarifications:
- Integer units are fine for all dimensions
- Widths, heights, and diameters must be POSITIVE.
- For the textbox: you onnly need to configure the text to display (which will be rendered horizontally within the bounding rectangle, don't worry about
face/size/alignment,etc).
- You DO NOT need to concern yourself with handling any input from the user, the widets will be hard-coded in the MAIN() method.
- Your console application should be abl eto 'print out' the current drawing by printing the key details of each widget (type, location, size/shape) to the console.
- You don't need to render the widgets in any manner, this is just a simulation.
- You must add one of each widget to the drawing as per the next stage.

Important:

- Unit testing: Pleaese include appropriate unit tests with your solution
- Readme: Finally, explain your design decisions in a readme file alongside your submitted solution. Also, mention any further work you would do if you had more time.
- Submission: Ensure that all the project files and folders are uploaded in a zip file. Ideally, EXCLUDE the bin and obj directories as they could risk a relay in your
submission due to antivirus processing.

GRADING:

Your exercise will be evaluated on your ability to follow requirements while demonstrating good programming practices such as:
- Maintainability
- Extensibility
- Robustness to changing requirements
- Testability
- SOLID principles

If you're invited to an interview, you will be expected to explain your design choices and you will be asked to amend your solution in response
to a requirement change.

Simulation:
In your Main method, ensure that the following widgets are added.
rectangle x=10, y=10, width=30 height=40
square x=15, y=30, size=35
ellipse x=100, y=150, horizontal diameter=300, vertical diameter=200
circle x=1, y=1, size=300
textbox x=5, y=5, width=200, height=100, text="sample text"
Required Output
As a result, when running the application, it must produce the following output
----------------------------------------------------------------
Requested Drawing
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 Text="sample text"
----------------------------------------------------------------