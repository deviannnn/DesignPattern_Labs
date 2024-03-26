using ShapeFactory;

SimpleShapeFactory factory = new SimpleShapeFactory();
DrawShape test = new DrawShape(factory);
test.draw(1, 2);
test.draw(2, 2);
test.draw(3, 2);
test.draw(1, 1);
test.draw(2, 1);
test.draw(3, 1);