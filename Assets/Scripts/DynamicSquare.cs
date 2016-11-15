﻿public abstract class DynamicSquare : Square {
    public abstract void Move();
    protected IntVector2 position
    {
        get { return base.position; }

        set { IntVector2 temp = base.position; base.position = value; Field.UpdateBlock(temp); Field.UpdateBlock(value); }
    }
    public DynamicSquare(IntVector2 position) : base(position) {

    }
}