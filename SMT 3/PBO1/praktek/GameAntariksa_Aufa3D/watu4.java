import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class watu4 here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class watu4 extends Actor
{
    /**
     * Act - do whatever the watu4 wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() 
    {
        // Add your action code here.
        setLocation(getX()-10, getY());
        if(getX() == 0){
            setLocation(1090, getY());
        }        
    }    
}
