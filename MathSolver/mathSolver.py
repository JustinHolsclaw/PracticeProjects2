# Question:
# You are given a string containing a mathematical expression with single-digit integers, addition (+), subtraction (-),
#  and parentheses ( ). Write a python function called EvaluateMathExpression that takes this string as input and returns the result of the mathematical expression.
def EvaluateMathExpression(expression):
    try:
        numberOfIterations = expression.index('(')
        print(numberOfIterations)
    except:
        print("here we are")
        return numberOfIterations

    # if(numberOfIterations > 1):
    #     EvaluateMathExpression()


EvaluateMathExpression("1+((1+2)+2)")


def EvaluateMathExpression2(expression):
    if(expression[0] == '('):
        partitionedExpressions = expression.partition('(')
        print(partitionedExpressions[2])
        EvaluateMathExpression2(partitionedExpressions[2])

EvaluateMathExpression2("1+((1+2)+2)")
# Note:
# The input expression will always be valid and well-formed.
# You can assume that the expression does not contain any spaces.
# You do not need to handle expressions with multi-digit integers.
# This question tests your ability to work with strings, basic arithmetic operations, and possibly recursion or stack-based algorithms for handling parentheses in mathematical expressions.