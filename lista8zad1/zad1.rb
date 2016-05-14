class Fixnum

    def prime?
        n = self
        if  n < 2
            return false
        end
        for i in 2 ..  Math.sqrt(n)
            if n % i == 0
                return false
            end
        end
        return true
    end

    def ack(y)
      if self == 0
        return y + 1
      end
      if y == 0
        return (self - 1).ack(1)
      end
      return (self - 1).ack(self.ack(y - 1))
    end

    def doskonala?
        suma = 0
        for i in 1...(self - 1)
          suma = suma + i if self % i == 0
        end
        if suma == self
          return true
        end
        return false
    end

    @@cyfry = ["zero", "jeden", "dwa", "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec"]

    def slownie
      return '' if self == 0
      (self / 10).slownie + @@cyfry[self % 10] + ' '
    end
end

puts 7.prime?
puts 14.prime?
puts 991.prime?
puts 992.prime?
puts
puts 1.ack(2)
puts 2.ack(1)
puts
puts 6.slownie
puts 61.slownie
puts 20829830.slownie
puts
puts 6.doskonala?
puts 7.doskonala?
puts 28.doskonala?
puts 21308.doskonala?

