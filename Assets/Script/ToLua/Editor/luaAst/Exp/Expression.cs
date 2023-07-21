﻿namespace Script.ToLua.Editor.luaAst
{
    public class Expression: LuaSyntaxNode
    {
        public InvocationExpression Invocation()
        {
            return new InvocationExpression(this);
        }
        
        public MemberAccessExpression MemberAccess(Expression name, bool isColon = false)
        {
            return new MemberAccessExpression(this, name, isColon);
        }
    }
}