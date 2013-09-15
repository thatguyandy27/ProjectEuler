
limit = 1000

letter_seperator = ''

def getWordForNumber(number)

  case number
  when 0
    return ''
  when 1
    return 'one'
  when 2 
    return 'two'
  when 3
    return 'three'
  when 4
    return 'four'
  when 5 
    return 'five'
  when 6
    return 'six'
  when 7
    return 'seven'
  when 8
    return 'eight'
  when 9
    return 'nine'
  when 10
    return 'ten'
  when 11
    return 'eleven'
  when 12
    return 'twelve'
  when 13
    return 'thirteen'
  when 14
    return 'fourteen'
  when 15
    return 'fifteen'
  when 16
    return 'sixteen'
  when 17
    return 'seventeen'
  when 18
    return 'eighteen'
  when 19
    return 'nineteen'
  when 20..29
    return 'twenty' + getWordForNumber(number - 20)
  when 30..39
    return 'thirty' + getWordForNumber(number - 30)
  when 40..49
    return 'forty' + getWordForNumber(number - 40)
  when 50..59
    return 'fifty' + getWordForNumber(number - 50)
  when 60..69
    return 'sixty' + getWordForNumber(number - 60)
  when 70..79
    return 'seventy' + getWordForNumber(number - 70)
  when 80..89
    return 'eighty' + getWordForNumber(number - 80)
  when 90..99
    return 'ninety' + getWordForNumber(number - 90)
  when 100
    return 'onehundred'
  when 101..199
    return 'onehundredand' + getWordForNumber(number - 100)
  when 200
    return 'twohundred'
  when 201..299
    return 'twohundredand' + getWordForNumber(number - 200)
  when 300
    return 'threehundred'
  when 301..399
    return 'threehundredand' + getWordForNumber(number - 300)
  when 400
    return 'fourhundred'
  when 401..499
    return 'fourhundredand' + getWordForNumber(number - 400)
  when 500
    return 'fivehundred'
  when 501..599
    return 'fivehundredand' + getWordForNumber(number - 500)
  when 600
    return 'sixhundred'
  when 601..699
    return 'sixhundredand' + getWordForNumber(number - 600)
  when 700
    return 'sevenhundred'
  when 701..799
    return 'sevenhundredand' + getWordForNumber(number - 700)
  when 800
    return 'eighthundred'
  when 801..899
    return 'eighthundredand' + getWordForNumber(number - 800)
  when 900
    return 'ninehundred'
  when 901..999
    return 'ninehundredand' + getWordForNumber(number - 900)
  when 1000
    return 'onethousand'
  end
end

def solution(limit)

  count = 0
  1.upto(limit) do |number|
    count += getWordForNumber(number).length
  end
  return count
end


count = solution(limit)

puts "The number of letters up to #{limit} is #{count}"