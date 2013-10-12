
file= "names.txt"

def totalScore(file)
  file = File.open(file, "r")
  sum = 0
  while line = file.gets()
    sum = wordScore(line)
  end
  
  return sum
end

def wordScore(line)
  words = line.split(",")
  count = 1
  totalSum = 0

  words.sort().each do |word|
    word.gsub!('"', '')
    sum = 0
    
    word.each_char do |c|
      sum += c.ord() - 64
    end
    score = sum * count
    if word == 'COLIN'
      puts "Score for word #{word} is #{score}.  #{sum}x#{count}"
    end

    totalSum += score
    count +=1
  end
  return totalSum
end

score = totalScore(file)
puts "The total score for #{file} is #{score}"