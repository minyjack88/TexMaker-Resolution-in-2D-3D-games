//a struct to repsent a point in a 2 aksese
struct Point
{
   public float x = 0;
   public float y = 0;
}

class Kamera
  {
    //The Position of camera in game world koordinate
    Point postion;

    int screenHeight;
    int screenWidth;

    // the amount of x and y game world koordinate the kamera can see
    static const float maxXOnScreen = 100;
    static const float maxYOnScreen = 100;

    Kamera(Point postion, int screenHeight, int screenWidth)
     {
         this.postion = postion;
         this.screenHeight = screenHeight;
         this.screenWidth = screenWidth;
     }

     Point PostionOnScreen(Point postion)
     {
         Point newPostion;
         newPostion.x = screenWidth/2 + 
         ( (postion.x - this.postion.x)* screenWidth/maxXOnScreen);
         newPostion.y = screenHeight / 2 + 
         ((postion.y - this.postion.y) * screenWidth / maxXOnScreen);
         return newPostion;
     }

  }

