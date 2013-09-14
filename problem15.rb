maxNumber = 2

def findSolution(number)
  return (2*number).downto(1).reduce(:*)/ (number.downto(1).reduce(:*)**2)
end

answer = findSolution(maxNumber)

puts "answer for #{maxNumber} is #{answer}."

maxNumber = 3
answer = findSolution(maxNumber)

puts "answer for #{maxNumber} is #{answer}."

maxNumber = 20
answer = findSolution(maxNumber)

puts "answer for #{maxNumber} is #{answer}."