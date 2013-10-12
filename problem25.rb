max = 10 ** 999

def findNumber(max)
  f1 = 1
  f2 = 1
  termNumber = 2
  while f1 < max
    temp = f1 + f2
    f2 = f1
    f1 = temp
    termNumber +=1
  end
  return termNumber
end

puts findNumber(max)