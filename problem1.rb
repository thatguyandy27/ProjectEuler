# Find the sum of all the multiples of 3 or 5 below 1000.

limit = 1000
divisors = [3,5]

total = 0
for i in 0...limit
  for divisor in divisors 
    if i % divisor == 0
      total += i
      break
    end
  end
end

print total