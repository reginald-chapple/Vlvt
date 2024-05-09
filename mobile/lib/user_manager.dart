import 'package:flutter_secure_storage/flutter_secure_storage.dart';

class UserManager {
  static final _storage = FlutterSecureStorage();

  Future<void> storeUserToken(String token) async {
    await _storage.write(key: 'userToken', value: token);
  }

  Future<String?> getUserToken() async {
    String? token = await _storage.read(key: 'userToken');
    return token;
  }

  Future<bool> checkToken() async {
    var token = await _storage.read(key: 'userToken');
    return token != null;
  }

  // You might also want to store other user details
  Future<void> storeUserId(String userId) async {
    await _storage.write(key: 'userId', value: userId);
  }

  Future<String?> getUserId() async {
    String? userId = await _storage.read(key: 'userId');
    return userId;
  }
}
