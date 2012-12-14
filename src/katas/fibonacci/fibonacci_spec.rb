require 'rubygems'
require 'rspec'
require './fibonacci'

describe Fibonacci do
  describe "Calculate Nth Fibonacci" do
    it "is 0 for 0" do
      Fibonacci.of(0).should == 0
    end
  end
end