def linReg(x,y): #linear regression
	n = len(x)
	b = ((n * sum(x[i] * y[i] for i in range(n)) - sum(x)*sum(y)) / ( n * sum(v**2 for v in x) - sum(x) ** 2))
	a = sum(y)/n - b * sum(x) / n
	return a,b

def regressionPrediction(x,y,x0): #regression prediction
	(a,b) = linReg(x,y)
	y0 = a + b*x0
	return y0
	
p = [15, 12, 8,  8,  7,  7,  7,  6,  5, 3]
h = [10, 25, 17, 11, 13, 17, 20, 13, 9, 15]

print(regressionPrediction(p, h, 10))