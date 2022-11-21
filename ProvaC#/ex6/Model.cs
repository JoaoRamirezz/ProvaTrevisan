public abstract class Enemy : Entity
{
    public int Column { get; set; }
    public int Line { get; set; }

    public abstract void Move();
    public abstract void Build();
}

public class Rock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); // Corpo não deslocado do centro original com tamanho 40x40
    }

    public override void Move()
    {
        Line++; //Cai
    }
}

public class TwoRock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 40, 40); // Corpo deslocado do centro
        build(60, 0, 40, 40); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 3; //Cai mais rápido
        Column++; //Cai em diagonal
    }
}
public class Palito : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(20, 5, 10, 320); // Corpo deslocado do centro
    }

    public override void Move()
    {
        Line += 3; //Cai mais rápido
        Column++; //Cai em diagonal
    }
}

public class ThreeRock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(500, 500, 30, 30); // Corpo deslocado do centro
    }

    public override void Move()
    {
        Line = 0; 
        Column = 0; 
    }
}

public class Plataforma : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 1000, 10); // Corpo deslocado do centro
        build(1060, 0, 1000, 10); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 1; //Cai mais rápido
        Column = 0; //Cai em diagonal
    }
}

public class Ramdom : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 40, 40); // Corpo deslocado do centro
        build(1060, 0, 40, 40); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 1; //Cai mais rápido
        Column = random(100); //Cai em diagonal
    }
}

public class Rapido : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 50, 50); // Corpo deslocado do centro
        build(1060, 0, 50, 50); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 10; //Cai mais rápido
        Column = 0; //Cai em diagonal
    }
}

public class Horizontal : Enemy
{
    public override void Build()
    {
        Column = 0;
        Line = 0;
        build(0, 1000, 50, 50); // Corpo deslocado do centro
    }

    public override void Move()
    {
        Line = 0; //Cai mais rápido
        Column += 1; //Cai em diagonal
    }
}