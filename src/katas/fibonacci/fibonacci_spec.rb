require 'rubygems'
require 'rspec'
require './fibonacci'

describe Fibonacci do
  it "is 0 when 0" do
    Fibonacci.of(0).should == 0
  end

  it "is 1 when 1" do
    Fibonacci.of(1).should == 1
  end
end
