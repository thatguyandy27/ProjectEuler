
class Problem56

  def initialize(a_max, b_max)
    @a_max = a_max
    @b_max = b_max
  end

  def find_solution
    max = 0

    1.upto(@a_max) do |a|
      new_max  = find_max(a)

      max = new_max if new_max > max
    end

    return max
  end

  private 

    def find_max(a)
      max = 0

      1.upto(@b_max) do |b|
        num = a ** b
        sum = find_sum(num)

        max = sum if sum > max

      end

      return max
    end

    def find_sum(num)
      sum = 0
      while num > 0
        sum += num %10
        num  = num / 10
      end

      return sum 
    end

end


problem56 = Problem56.new(100,100)

puts problem56.find_solution