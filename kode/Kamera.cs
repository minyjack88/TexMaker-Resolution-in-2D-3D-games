//A struct to represent a point in 2 axes.
struct Point
{
   public float x = 0;
   public float y = 0;
}

class Camera
  {
    //The Position of the camera in game world coordinates.
    Point position;

    int screenHeight;
    int screenWidth;

    // the amount of width(x) and hight(y) game world coordinates the camera can see.
    static const float maxXOnScreen = 100;
    static const float maxYOnScreen = 100;

    Camera(Point position, int screenHeight, int screenWidth)
     {
         this.position = position;
         this.screenHeight = screenHeight;
         this.screenWidth = screenWidth;
     }

    Point positionOnScreen(Point position)
     {
         Point newPosition;
         newPosition.x = screenWidth / 2 +
         ((position.x - this.position.x) * screenWidth / maxXOnScreen);
         newposition.y = screenHeight / 2 +
         ((position.y - this.position.y) * screenWidth / maxXOnScreen);
         return newPosition;
     }

  }

