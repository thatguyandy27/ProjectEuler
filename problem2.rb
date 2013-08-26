#By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

limit = 4000000
total = 0
number1 = 0
number2 = 1

while number2 < limit do
  nextNumber = number1 + number2
  if nextNumber < limit && nextNumber % 2 == 0
    total += nextNumber
  end
  number1 = number2
  number2 = nextNumber
  
end

print total 