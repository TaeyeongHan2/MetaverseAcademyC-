using UnityEngine;
using UnityEngine.Serialization;

public class Figure
{
    public int x;
    public int y;
    
    public virtual void Show()
    {
        //인스턴스 생성
        Figure yuhiyu = new Triangle();
        Figure yttyu = new Rectangle();
        Figure c = new Circle();
        Figure[] C = new Figure[100];
       
        Circle cc = (Circle)c;
       
        //위에서 만든 인스턴스를 변수에 할당


    }
}