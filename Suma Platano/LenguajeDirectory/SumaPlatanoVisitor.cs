using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;

namespace Suma_Platano.Lenguaje
{
    class SumaPlatanoVisitor : LenguajeBaseVisitor<double>
    {
        public List<double> ListaDeImpresion = new List<double>();
        public Dictionary<string, double> TablaDeSimbolos = new Dictionary<string, double>();
        
        //
        //Declaracion de variables
        //
        public override double VisitDeclaracion_var(LenguajeParser.Declaracion_varContext context)
        {
            TablaDeSimbolos.Add(context.ID().GetText(), 0);
            return 0;
        }

        //
        //Asignacion de variables
        //
        public override double VisitAsignacion_var(LenguajeParser.Asignacion_varContext context)
        {
            //listaSimbolos[context.ID().GetText()] = double.Parse(context.expresion().value.ToString());
            string ID = context.ID().GetText();
            double Valor = Visit(context.expresion());
            TablaDeSimbolos[ID] = Valor;
            return Valor;
        }

        //
        //Imprimir
        //
        public override double VisitImprimir(LenguajeParser.ImprimirContext context)
        {
            double Valor = Visit(context.expresion());
            ListaDeImpresion.Add(Valor);
            return 0;
        }

        //
        //ID
        //
        public override double VisitValorExpresion(LenguajeParser.ValorExpresionContext context)
        {
            string ID = context.ID().GetText();
            return TablaDeSimbolos.ContainsKey(ID) ? TablaDeSimbolos[ID] : 0 ;
        }

        //
        //Numero
        //
        public override double VisitNumeroExpresion(LenguajeParser.NumeroExpresionContext context)
        {
            return double.Parse(context.NUMERO().GetText());
        }

        //
        //Suma y Resta
        //
        public override double VisitSumResExpresion(LenguajeParser.SumResExpresionContext context)
        {
            double izquierdo = Visit(context.expresion(0));
            double derecho = Visit(context.expresion(1));

            if (context.op.Type == LenguajeParser.SUMA)
            {
                return izquierdo + derecho;
            }
            else
            {
                return izquierdo - derecho;
            }
        }

        //
        //Multiplicacion y Division
        //
        public override double VisitMulDivExpresion(LenguajeParser.MulDivExpresionContext context)
        {
            double izquierdo = Visit(context.expresion(0));
            double derecho = Visit(context.expresion(1));

            if (context.op.Type == LenguajeParser.MULTIPLICACION)
            {
                return izquierdo * derecho;
            }
            else
            {
                return izquierdo / derecho;
            }
        }

        //
        //Parentesis
        //
        public override double VisitParentExpresion(LenguajeParser.ParentExpresionContext context)
        {
            return Visit(context.expresion());
        }
    }
}
