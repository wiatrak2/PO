class Jawna

  def initialize (decrypt)
      @decrypt = decrypt
  end

  def zaszyfruj(klucz)
    for i in 0...@decrypt.length
        @decrypt[i] = (@decrypt[i].ord + klucz).chr
    end
    Zaszyfrowane.new(@decrypt)
  end

  def to_s
      @decrypt
  end
end

class Zaszyfrowane

  def initialize (encrypt)
      @encrypt = encrypt
  end

  def odszyfruj (klucz)
    for i in 0...@encrypt.length
        @encrypt[i] = (@encrypt[i].ord - klucz).chr
    end
    Jawna.new(@encrypt)
  end

  def to_s
      @encrypt
  end
end

decrypted = Jawna.new('Ala ma kota')
puts decrypted
encrypted = decrypted.zaszyfruj 3
puts encrypted
decrypted = encrypted.odszyfruj 3
puts decrypted