import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class MyWorld here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class MyWorld extends World
{

    /**
     * Constructor for objects of class MyWorld.
     * 
     */
    public MyWorld()
    {    
        // Create a new world with 600x400 cells with a cell size of 1x1 pixels.
        super(1100, 600, 1);
        tampilkanAktor();
        tampilkanWatu();
        tampilkanWatu1();
        tampilkanWatu2();
        tampilkanWatu3();
        tampilkanWatu4();
        tampilkanWatu5();
        tampilkanWatu6();
        tampilkanWatu7();
        tampilkanWatu8();
        tampilkanjekpot();
    }
    private void tampilkanAktor() {
        //menampilkan pesawat
        addObject(new pesawat(), 50,300);
    }
    private void tampilkanWatu(){
        //menampilkan watu
        addObject(new watu(), 1090,10);
    }
    private void tampilkanWatu1(){
        //menampilkan watu
        addObject(new watu1(), 1090,60);
    }
    private void tampilkanWatu2(){
        //menampilkan watu
        addObject(new watu2(), 1090,120);
    }
    private void tampilkanWatu3(){
        //menampilkan watu
        addObject(new watu3(), 1090,180);
    }
    private void tampilkanWatu4(){
        //menampilkan watu
        addObject(new watu4(), 1090,240);
    }    
    private void tampilkanWatu5(){
        //menampilkan watu
        addObject(new watu5(), 1090,300);
    }
    private void tampilkanWatu6(){
        //menampilkan watu
        addObject(new watu6(), 1090,360);
    }
    private void tampilkanWatu7(){
        //menampilkan watu
        addObject(new watu7(), 1090,420);
    }
    private void tampilkanWatu8(){
        //menampilkan watu
        addObject(new watu8(), 1090,480);
    }
    private void tampilkanjekpot(){
        //menampilkan watu
        addObject(new jekpot(), 1090,560);
    }       
}
