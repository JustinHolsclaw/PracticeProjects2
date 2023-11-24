

def findLargestNumber(expression):
    if expression[0] == '(':
        expression.pop(0)
        findLargestNumber()
    else:
        i == 0
        parenthesisExpression = []
        while expression[i] != ')':
            parenthesisExpression.append(expression[i])
            expression.pop(i)
            i = i + 1
        
    
        
            






expression = "((2+3)-1)"