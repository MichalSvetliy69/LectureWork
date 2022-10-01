class Square : Imagine
{
    int _a;
    
    public Draw (image) 
    {
        for (int i = 0; i < _a; i++)
        {
            int j = 0;
            image.SetPixel(i,j);

            
            
        }
          for (int i = 0; i < _a; i++)
        {
            int i = 0;
            image.SetPixel(i,j);

            
            
        }

            for (int i = 0; i < _a; i++)
        {
            int i = _a;
            image.SetPixel(i,j);

            
            
        }

             for (int i = 0; i < _a; i++)
        {
            int j = _a;
            image.SetPixel(i,j);

            
            
        }

        
        
    }

}




main
{
    Square square = new Square(10);
    Image image = new Image;
    square.Draw(image);



}