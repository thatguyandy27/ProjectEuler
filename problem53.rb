
class Problem53

  def initialize(threshold, max)
    @threshold = threshold
    @max = max

  end

  def get_values()
    count = 0
    1.upto(@max) do |value|
      count += process_number(value)
    end

    return count
  end

  private 
    def process_number(n)
      count = 0
      n_fact = n.downto(1).inject(:*)
      1.upto(n) do |r|

        x = 1
        x = (n - r).downto(1).inject(:*) if n-r > 0

        result = n_fact/ (r.downto(1).inject(:*) * x)
        count += 1 if result >= @threshold
      end

      return count
    end

end

problem53 = Problem53.new(1000000, 100)

puts problem53.get_values
