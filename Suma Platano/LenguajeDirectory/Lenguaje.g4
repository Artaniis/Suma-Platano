grammar Lenguaje;

/*
 * Parser Rules
 */

compileUnit			:   programa EOF;

programa			:	PROGRAMA ID LLAVE_A sentencia* LLAVE_C;

sentencia			:	declaracion_var | asignacion_var | imprimir;

declaracion_var		:	VARIABLE ID PUNTOyCOMA;

asignacion_var		:	ID ASIGNACION expresion PUNTOyCOMA;

imprimir			:	IMPRIMIR PARENTESIS_A expresion PARENTESIS_C PUNTOyCOMA;

expresion returns [object value]
			:	expresion op = (MULTIPLICACION | DIVISION) expresion	#mulDivExpresion 
			|	expresion op = (SUMA | RESTA) expresion					#sumResExpresion
			|	NUMERO													#numeroExpresion
			|	ID														#valorExpresion
			|	PARENTESIS_A expresion PARENTESIS_C						#parentExpresion
			;


 

/*
 * Lexer Rules
 */

COMENTARIO_SIMPLE	:	'-->' [ \t\n\ra-zA-Z0-9_]* -> skip;

PROGRAMA			:	'programa';
VARIABLE			:	'variable';
IMPRIMIR			:	'imprimir';
SI					:	'Si';
ENTONCES			:	'Entonces';
PARA				:	'Para';
MIENTRAS			:	'Mientras';

LLAVE_A				:	'{';
LLAVE_C				:	'}';
CORCHETE_A			:	'[';
CORCHETE_C			:	']';
PARENTESIS_A		:	'(';
PARENTESIS_C		:	')';
PUNTO				:	'.';
COMA				:	',';
DOSPUNTOS			:	':';
PUNTOyCOMA			:	';';
ASIGNACION			:	'=';
SUMA				:	'+';
RESTA				:	'-';
MULTIPLICACION		:	'*';
DIVISION			:	'/';
POTENCIA			:	'^';

OP_INCREMENTO		:	'++';
OP_DECREMENTO		:	'--';
OP_Y				:	'YY';				// &&
OP_O				:	'OO';				// ||
OP_NEGACION			:	'#';				// !
OP_MAYOR_Q			:	'>';
OP_MENOR_Q			:	'<';
OP_MAYOR_IG			:	'>=';
OP_MENOR_IG			:	'<=';
OP_IGUALDAD			:	'<>';				// ==
OP_DESIGUALDAD		:	'><';				// !=
OP_SUMAyASIG		:	'+=';
OP_RESTAyASIG		:	'-=';
OP_MULTyASIG		:	'*=';
OP_DIVyASIG			:	'/=';

BOOLEAN				:	'verdadero' | 'falso';

ID					:	[a-zA-Z_][a-zA-Z0-9_]*;

NUMERO				:	'0' | [1-9][0-9]* | [1-9][0-9]* '.' [0-9]+ ;

ESPACIOeB			:	[ \t\n\r]+ -> skip;

