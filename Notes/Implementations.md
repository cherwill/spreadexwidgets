Shape Class / Interface ?:
- Properties:
    - x value
    - y value
- Behaviours:
    - GetDimensions()
    - GetLocation(), should probably have an implementation as it probably won't differ for other shapes...

Rectangle:
- Properties:
    - Width
    - Height
- Behaviours:
    - Constructor that accepts an x value, y value, width, height
    - Implementation for GetDimensions, which outputs the Width and Height

Square:
- Properties:
    - Size
- Behaviours:
    - Constructor that accepts an x value, y value, size
    - Implementation for GetDimensions, which outputs the Width

Ellipse:
- Properties:
    - Horizontal Diameter
    - Vertical Diameter
- Behaviours:
    - Constructor that accepts an x value, y value, hDiameter, vDiameter
    - Implementation for GetDimensions, which outputs H and V Diameter

Circle:
- Properties:
    - Diameter
- Behaviours:
    - Constructor that accepts an x value, y value, size
    - Implementation for GetDimensions, which outputs Diameter

Textbox:
- Properties:
    - fontSize: 1
    - text
    - Rectangle
- Behaviours:
    - Constructor that accepts an x value, y value, width, height, text
    - Implementation for CalculateTextSize, which gets the length of text multiplied by font size: 
    - Implementation for CalculateTextPosition, which ensures that the text has even padding left + right
    - Implementation for GetDimensions, which outputs the value of CalculateDimensions