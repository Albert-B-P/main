require File.dirname(__FILE__) + '/../../../spec_helper'
require File.dirname(__FILE__) + '/../shared/constants'
require 'openssl'

describe "OpenSSL::HMAC.digest" do
  it 'returns an SHA1 digest' do
    cur_digest = OpenSSL::Digest::Digest.new('SHA1')
    cur_digest.digest.should == HMACConstants::BlankSHA1Digest
    digest = OpenSSL::HMAC.digest(cur_digest,
                                        HMACConstants::Key,
                                        HMACConstants::Contents)
    digest.should == HMACConstants::SHA1Digest
  end
end

# Should add in similar specs for MD5, RIPEMD160, and SHA256
